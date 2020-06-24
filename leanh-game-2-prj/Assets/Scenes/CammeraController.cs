using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CammeraController : MonoBehaviour
{
    public GameObject cube;
    //Khởi tạo layer có thể tùy chỉnh bởi người dùng
    public LayerMask layer;
    private void Update()
    {
        //Tạo hàm raycast : lấy thông tin 
        RaycastHit hit;
        //Nếu giữ chuột 
        if (Input.GetButton("Fire1"))
        {
            //Tạo tia từ Cammera đến điểm dc chọn (vị trí chuột)
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Check xem tia vừa tạo có cắt vật thể nào không 
            //Physics.Raycast(tia (ray) , điểm va chạm(out hit), khoảng cách lớn nhất (1000), layer chịu ảnh hưởng )
            if (Physics.Raycast(ray, out hit, 1000, layer))
            {
                //Vẽ tia đi từ mốc ray.origin đến điểm va chạm hit.point
                Debug.DrawLine(ray.origin, hit.point);

                Debug.Log(hit.point);
                //dịch chuyển Cube
                cube.transform.position = hit.point;
            }
        }
    }
}





