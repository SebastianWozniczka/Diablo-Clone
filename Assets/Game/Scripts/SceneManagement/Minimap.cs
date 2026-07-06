using UnityEngine;

public class Minimap : MonoBehaviour
{

    public GameObject player,minimap;

    private bool isActive = false;
    

    private void LateUpdate()
    {
        minimap.transform.position = new Vector3(player.transform.position.x, 40, player.transform.position.z);
        if (Input.GetKeyDown(KeyCode.Tab)) isActive =  !isActive;
        minimap.gameObject.active = isActive;


    }
    void Start()
    {
       
        
    }

    void Update()
    {
        
    }
}
