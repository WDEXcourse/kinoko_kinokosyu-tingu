using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private float JumpPower = 4;

    [SerializeField]
    private float MoveSpeed = 0;

    private CharacterController characterController;
    private Vector3 Velocity;
    public float sensitivityX = 15f;
    public float sensitivityY = 15f;
    public float minimumX = -360f;
    public float manimumX = 360f;
    public float minimumY = -60f;
    public float manimumY = 60f;
    float rotationX = 0f;
    public float rotationY = 0f;
    public GameObject VerRot;
    public GameObject HorRot;
    public GameObject Arrow;
    [SerializeField]
    private float ArrowSpeed = 80;
    private Vector3 force;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            characterController.Move(this.gameObject.transform.forward * MoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            characterController.Move(this.gameObject.transform.forward * -1 * MoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            characterController.Move(this.gameObject.transform.right * -1 * MoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            characterController.Move(this.gameObject.transform.right * MoveSpeed * Time.deltaTime);
        }
        characterController.Move(Velocity * Time.deltaTime);
        Velocity.y += Physics.gravity.y * Time.deltaTime;
        if (characterController.isGrounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Velocity.y = JumpPower;
            }
        }

        rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        rotationY = Mathf.Clamp(rotationY, minimumY, manimumY);
        VerRot.transform.localEulerAngles = new Vector3(-rotationY, 0, 0);
        HorRot.transform.localEulerAngles = new Vector3(0, rotationX, 0);
        if (Input.GetMouseButtonDown(0))
        {
            
            GameObject Arrows = Instantiate(Arrow,this.transform.position,this.transform.rotation) as GameObject;
            // Arrows.transform.position = this.transform.position;
            force = this.gameObject.transform.forward * ArrowSpeed;
             Arrows.GetComponent<Rigidbody>().AddForce(force);
             Destroy(Arrows.gameObject, 4);

           
        }
    }
}

