// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class SnakeBody : MonoBehaviour
// {
//     private SnakeMovement snakeHead;
//     private int i = 0;
//     Vector3 snakePos;

//     void Start()
//     {
//         // transform.position = new Vector3(0,0,0);
//         snakeHead = FindObjectOfType<SnakeMovement>();
//     }

    
//     void Update()
//     {
//         snakePos = snakeHead.snake.transform.position;
       
//     }

//     private void FixedUpdate()
//     {
        
//         if(i % 6 == 0)
//         {
//             transform.position = new Vector3(
//             snakePos.x + 0.3f, snakePos.y, 0f
//             );
//         }
//         i++;
//     }
// }
