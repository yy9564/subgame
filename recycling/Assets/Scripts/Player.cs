using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerAnim
{
    public AnimationClip idle;
    public AnimationClip walk;
}

public class Player : MonoBehaviour
{
    float h, v;
    public float moveSpeed = 0.1f;
    public float rotateSpeed = 100.0f;
    Transform tr;
    public PlayerAnim playerAnim;
    Animation anim;

    // Use this for initialization
    void Start()
    {
        tr = GetComponent<Transform>();
        anim = GetComponent<Animation>();
        //tr = GetComponent("Transform") as Transform;
        //tr = gameObject.GetComponent<Transform> ();
        //tr = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
        tr.Translate(moveDir.normalized * moveSpeed * Time.deltaTime);
        tr.Rotate(Vector3.up * rotateSpeed * Time.deltaTime * Input.GetAxis("Mouse X"));

        if (v >= 0.1f)
        {
            anim.CrossFade(playerAnim.walk.name, 0.3f);
        }
        else if (v <= -0.1f)
        {
            anim.CrossFade(playerAnim.walk.name, 0.3f);
        }
        else if (h >= 0.1f)
        {
            anim.CrossFade(playerAnim.walk.name, 0.3f);
        }
        else if (h <= -0.1f)
        {
            anim.CrossFade(playerAnim.walk.name, 0.3f);
        }
        else
        {
            anim.CrossFade(playerAnim.idle.name, 0.3f);
        }
    }
}
