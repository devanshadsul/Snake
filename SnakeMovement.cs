using UnityEngine;
using System.Collections.Generic;

public class SnakeMovement : MonoBehaviour
{
    private List<Transform> Segments;
    public Transform SegmentPrefab;
    public Point pointSys;
    //public GameObject snake;
    private Vector2 direction = new Vector2(1,0);
    private int ib = 0;
    private float sizeInc = 1f;
    //private Vector3 Iposition;
    private Vector3 currentPos;
    
    

    void Start()
    {
        Segments = new List<Transform>();
        Segments.Add(this.transform);
    }

     void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            direction = Vector2.up;
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            direction = Vector2.left;
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            direction = Vector2.down;
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            direction = Vector2.right;
        }
    }

    void FixedUpdate()
    {
        
        
        if(ib % 6 == 0)
        {
            for(int i = Segments.Count - 1; i> 0; i--)
            {
            Segments[i].position = Segments[i - 1].position;
            }

            transform.position = new Vector3(
            transform.position.x + direction.x, transform.position.y + direction.y, 0f
            );
            currentPos = transform.position;
        }
        ib++;
    }

    void OnTriggerEnter2D(Collider2D collide)
    {
        if(collide.CompareTag("Wall") || collide.CompareTag("snakeBody"))
        {
            
            Reset();
            
        }

        if(collide.gameObject.CompareTag("Point"))
        {
            Grow();
            pointSys.PointSystem();
            Debug.Log("crashed");
            
        }
    }

    void Grow()
    {
    Transform snakeGrowth = Instantiate(SegmentPrefab);
    snakeGrowth.position = Segments[Segments.Count - 1].position;
    Segments.Add(snakeGrowth);
        
    }

    void Reset()
    {
       for (int i = 1; i < Segments.Count; i++)
            {
                Destroy(Segments[i].gameObject);
            }

            transform.position = new Vector3(0,0,0);
            //Segments = new List<Transform>();
            Segments.Clear();
            Segments.Add(this.transform);
    }
}
