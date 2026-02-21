using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;


    
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{

    [SerializeField] InputSystem_Actions inputReader;

   
   public Rigidbody rb;

    private Animator anim;

    
    public StateMachine stateMachine;


    [Header("Player Movement Variables")]
   
    [SerializeField] private float pSpeed = 4f;
    [SerializeField] private float rotateSpeed = 10f;



    public Vector2 moveInput;
    public bool isMoving;


    void Awake()

    {

        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();


        //Initialize State Machine
        stateMachine = new StateMachine();
        stateMachine.Initialize(this);


    }

    void OnEnable()
    {

        
    }

    void OnDisable()
    {

    }


    void Update()
    {
        GetInteract();
    }

    void FixedUpdate()
    {

    }
    public void GetInteract()
    {

      
    }

}
