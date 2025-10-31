using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{


    // 1. หน้าที่เกี่ยวกับการเคลื่อนที่
    public void Move(PlayerData playerData, float deltaX, float deltaY)
    {
        playerData.PositionX += deltaX;
        playerData.PositionY += deltaY;
        Debug.Log($"{playerData.PlayerName} moved to ({playerData.PositionX}, {playerData.PositionY})");
    }
}

