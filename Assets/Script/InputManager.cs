using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private PlayerController pc;
    [SerializeField] private int no0fPlayer;
    private Vector2 direction;

    private void GetDirection()
    {
        direction.x = Input.GetAxis("HorizontalP"+ no0fPlayer);
        direction.y = Input.GetAxis("VerticalP" + no0fPlayer);
    }
    void Update()
    {
        GetDirection();
        pc.Move(direction);
    }
}
