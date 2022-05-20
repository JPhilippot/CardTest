using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIMovement
{
    public void CreateMovementCardFromMiniCard(VisualElement miniCard,VisualElement cardRoot)
    {
        switch (miniCard.name)
        {
            case "LinearMovement":
                
                break;
            case "SinusoidMovement":
                break;
            case "EllipsoidMovement":
                break;
            case "ArcMovement":
                break;
            case "SpiralMovement":
                break;
            case "LemniscateMovement":
                break;
            default:
                Debug.Log("Wut?");
                break;
        }
    }
}
