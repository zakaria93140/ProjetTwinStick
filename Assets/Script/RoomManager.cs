using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    [SerializeField] private GameObject[] enemys;
    [SerializeField] private GameObject[] doors;
    [SerializeField] private bool[] playersIsInTheRoom;
    
    private void AllPlayerAreInTheRoom()
    {
        foreach (GameObject door in doors)
        {
            door.SetActive(true);
        }

        foreach (GameObject enemy in enemys)
        {
            enemy.SetActive(true);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out InputManager inputManager))
        {
            playersIsInTheRoom[inputManager.no0fPlayer - 1] = true;
            if (playersIsInTheRoom[0] && playersIsInTheRoom[1])
            {
                AllPlayerAreInTheRoom();
            }
        }
    }
}
