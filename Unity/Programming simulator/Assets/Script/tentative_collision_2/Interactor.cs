using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactor : MonoBehaviour
{
    public LayerMask interactableLayermask= 8;
    UnityEventQueueSystem onInteract;
    Interactable interactable;
    //public ImageConversion interactImage;
    public Sprite defaultIcon;
    public Vector2 defaultIconSize;
    public Sprite defaultInteracticon;
    public Vector2 defaultInteractionSize;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position,Camera.main.transform.forward,out hit, 2, interactableLayermask))
        {
           if(hit.collider.GetComponent<Interactable>() != false)
            {
              //  onInteract = hit.collider.GetComponent<Interactable>().OnInteract;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    //onInteract.in
                }

                
                
                //if(Interactable == null || Interactable.ID != hit.collider.GetComponent<Interactable>().ID)
               // {
                 //   interactable = hit.collider.GetComponenent<Interactable>();
               // }
              //  if(Interactable.interaction != null)
              //  {
               //     interactImage.sprite = Interactable.interaction;
               //     if(interactable.iconSize == Vector2.zero)
              //      {
              //          interactImage.rectTransform;sizeDelta = defaultInteractIconSize;
              //      }
             //   }
             //   else
             //   {
             //       interactImage.sprite = defaultInteractIcon;
             //       interactImage.rectTransform.sizeDelta = defaultInteractIconSize;
             //   }
             //   if (Input.GetKeyDown(KeyCode.E))
             //   {
              //      Interactable.onInteract.Invoke();
              //  }
            }   
        }
       // else
        {
           // if(interactImage.sprite != defaultIcon)
            {
            //    interactImage.sprite = defaultIcon;
            //    interactImage.rectTansform.SizeDelta = defaultIconSize;
            }
        }
    }
}
