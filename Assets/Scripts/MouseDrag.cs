using UnityEngine;
using System.Collections;


public class MouseDrag : MonoBehaviour
{
    private Vector3 mousePosition;

    void OnMouseDown()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
    }
    void OnMouseDrag()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = Vector2.Lerp(transform.position, mousePosition, 15F);
    }

}
