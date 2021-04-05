using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject UI, player, target;

    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)  && Vector3.Distance(target.transform.position, player.transform.position) < 3.0f )
        {
            UI.SetActive(true);
        }
    }
}
