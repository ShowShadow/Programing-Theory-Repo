using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler : MonoBehaviour
{
    Text informationText;

    // Start is called before the first frame update
    void Start()
    {
        informationText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnClick(); //ABSTRACTION
           
        }
    }

    public void OnClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            InvokeRepeating("GemsRotate", 0.3f, 0.1f);

            if (hit.collider.gameObject.TryGetComponent(out Gems gems))
            {
                informationText.text = gems.DisplayText(); //ABSTRACTION
            }
        }
    }

    public void GemsRotate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            hit.collider.gameObject.transform.Rotate(0, 10, 0, Space.World);
        }   
    }
}
