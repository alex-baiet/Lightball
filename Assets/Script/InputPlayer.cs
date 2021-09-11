using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer : MonoBehaviour
{
    public static float GetAxisHorizontal(int playerId)
    {
        if (playerId == 0) { return Input.GetAxis("Horizontal"); }
        else { return Input.GetAxis("Horizontal2"); }
    }
    public static float GetAxisRawHorizontal(int playerId)
    {
        if (playerId == 0) { return Input.GetAxisRaw("Horizontal"); }
        else { return Input.GetAxisRaw("Horizontal2"); }
    }

    public static float GetAxisVertical(int playerId)
    {
        if (playerId == 0) { return Input.GetAxis("Vertical"); }
        else { return Input.GetAxis("Vertical2"); }
    }
    public static float GetAxisRawVertical(int playerId)
    {
        if (playerId == 0) { return Input.GetAxisRaw("Vertical"); }
        else { return Input.GetAxis("Vertical2"); }
    }

    public static bool GetKeyDownRestartPoint()
    {
        return Input.GetKeyDown(KeyCode.R);
    }
}
