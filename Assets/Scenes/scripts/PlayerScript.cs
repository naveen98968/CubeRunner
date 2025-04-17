using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rd;
    public float force = 1000f;
    public float speed = 10f;
    public float minX;
    public float maxX;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x,minX,maxX);
        transform.position = playerPos;
        if (Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D))
        {
           transform.position = transform.position + new Vector3(speed * Time.deltaTime,0,0);
        } 
        if (Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
        {
           transform.position = transform.position - new Vector3(speed * Time.deltaTime,0,0);
        } 
       
    }


    private void FixedUpdate()
    {
        rd.AddForce(0,0,force * Time.deltaTime);
    }



}