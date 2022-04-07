using UnityEngine;

public class Top : MonoBehaviour
{
    // Start is called before the first frame update
Vector2 differ;
 bool isStarted = false;
  [SerializeField] Pedal pedal;
  [SerializeField] float x=2f;
  [SerializeField] float y=15f;
    void Start()
    {
        differ = transform.position - pedal.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(!isStarted)
        {
            TopinPedal();
            mouseClick();
        }
    }

     private void TopinPedal()
    {
        Vector2 pedalPoz = new Vector2(pedal.transform.position.x, pedal.transform.position.y);
         transform.position = pedalPoz + differ ;
      
    }

     private void mouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(x, y);
        }
    }

   

   


}
