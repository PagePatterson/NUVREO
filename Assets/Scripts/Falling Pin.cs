using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPin : MonoBehaviour
{
    private bool hasFallen = false;
    private Vector3 initialPosition;
    public float fallAngleThreshold = 30f;
    public float disappearTime = 3f;


    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasFallen)
        {
            float angle = Vector3.Angle(transform.up, Vector3.up);

            if (angle > fallAngleThreshold)
            {
                hasFallen = true;
                ScoreManager.Instance.UpdateScore();

                StartCoroutine(DisappearAfterTime(disappearTime));
            }
        }
    }

    private IEnumerator DisappearAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);
    }
}
