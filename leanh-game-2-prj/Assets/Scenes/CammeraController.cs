using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CammeraController : MonoBehaviour
{
    public GameObject cube;
    
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
            //Physics.Raycast(tia (ray) , điểm va chạm (out hit), khoảng cách lớn nhất (1000) )
            if (Physics.Raycast(ray, out hit, 1000 ))
            {
                if (hit.collider.gameObject.tag == "Cube")
                {
                    Debug.DrawLine(ray.origin, hit.point);
                    Debug.Log(hit.point);
                    cube.transform.position = new Vector3(hit.point.x, 0.5f, hit.point.z);
                }
      
            }
          
        }
        
    }
}


   


