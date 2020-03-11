using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanelSwiper : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private Vector3 PanelLocation;
    public float percentThreshold = 0.2f;
    public float easing = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        PanelLocation = transform.position;
    }

    public void OnDrag(PointerEventData data)
    {
        float difference = data.pressPosition.x - data.position.x;
        transform.position = PanelLocation - new Vector3(difference, 0, 0);
    }

    public void OnEndDrag(PointerEventData data)
    { 
        float Percentage = (data.pressPosition.x - data.position.x) / Screen.width;
        if (Mathf.Abs(Percentage) >= percentThreshold)
        {
            Vector3 newLocation = PanelLocation;
            if (Percentage > 0)
            {
                newLocation += new Vector3(-Screen.width, 0, 0);
            }
            else if (Percentage < 0)
            {
                newLocation += new Vector3(Screen.width, 0, 0);
            }
            StartCoroutine(SmoothMove(transform.position, newLocation, easing));
            PanelLocation = newLocation;
        }
        else 
        {
            StartCoroutine(SmoothMove(transform.position, PanelLocation, easing));
        }
    }

    IEnumerator SmoothMove(Vector3 startpos, Vector3 endpos, float seconds)
    {
        float t = 0f;
        while(t <= 1.0)
        {
            t += Time.deltaTime / seconds;
            transform.position = Vector3.Lerp(startpos, endpos, Mathf.SmoothStep(0f, 1f, t));
            yield return null;

        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
