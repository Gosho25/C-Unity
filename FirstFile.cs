using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.InputSystem.XR;
using static UnityEngine.GraphicsBuffer;

[RequireComponent(typeof(CharacterController))] 
public class FirstFile : MonoBehaviour
{


    [SerializeField] private float speed = 8f;//скорост 
    [SerializeField] private float rotationSpeed = 70;//скорост на въртене
    [SerializeField] private float gravity = -26f;//сила на гравитацията(отрилцателна, за да дърпа към земята)
    [SerializeField] private float jumpSpeed = 10;//скорост на скок   
     
    [SerializeField] private float airControlSpeed = 7f;
    [SerializeField] private float sprinting = 15f;//тичане 

    [SerializeField] private Transform camTrans;//В Unity SampleScene следи Main камерата
    }
}
