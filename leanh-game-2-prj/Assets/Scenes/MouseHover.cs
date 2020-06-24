using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour
{
    //Khởi tạo màu Ban đầu 
    public Color startColor;
    //Khởi tạo màu sau khi hover
    public Color hoverColor;
    //Khởi tạo hàm check sự kiện nếu con trỏ chuột di chuyển
    //đến vật thể
    bool mouseHover = false;
    //Tạo hàm di chuyển con trỏ đến vật thể 
    private void OnMouseEnter()
    {
        //khi con trỏ chuột di chuyển đến vật thể 
        //kích hoạt hàm check 
        mouseHover = true;
        //Gọi component Renderer để chuyển vật liệu của vật thể qua màu 
        //tùy chỉnh sau khi di chuyển con trỏ chuột vào
        GetComponent<Renderer>().material.SetColor("_Color",hoverColor);
    }
    //Tạo hàm di chuyển con trỏ ra khỏi vật thể 
    private void OnMouseExit()
    {
        //khi con trỏ chuột di chuyển khỏi vật thể 
        //ngắt hoạt hàm check 
        mouseHover = false;
        //Gọi component Renderer để chuyển vật liệu của vật thể qua màu 
        //tùy chỉnh sau khi di chuyển con trỏ chuột ra khỏi vật thể
        GetComponent<Renderer>().material.SetColor("_Color", startColor);
    }
   
}
