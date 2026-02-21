using System;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public Texture2D textureCursor;

    public CursorMode cursormode = CursorMode.Auto;
    public Vector2 offset = Vector2.zero;

    private void Awake()
    {

        Cursor.SetCursor(textureCursor, offset, cursormode);
    }

    private static void SetCursor(Texture2D textureCursor, Vector2 offset, CursorMode cursormode)
    {
        throw new NotImplementedException();
    }
}
