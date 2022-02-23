using UnityEngine;

public class Walker : MonoBehaviour
{
    public float Movespeed = 3;
    public float Turnspeed = 145;
    private Animator anim = null;

    private void Start()
    {
        anim = this.GetComponent<Animator>();
    }
    private void Update()
    {
        float vert = Input.GetAxis("Vertical");     //arrow keys / WASD keyboard   (-1..0..1)
        float horz = Input.GetAxis("Horizontal");

        this.transform.Translate(Vector3.forward * vert * Movespeed * Time.deltaTime);
        this.transform.Rotate(Vector3.up, horz * Turnspeed * Time.deltaTime);

        if (vert > 0)
        {
            anim.SetBool("isRunning", true);
            anim.SetFloat("RunningSpeed", 1);
        }
        else if (vert < 0)
        {
            anim.SetBool("isRunning", true);
            anim.SetFloat("RunningSpeed", -1);
        }
        else if (vert == 0)
        {
            anim.SetBool("isRunning", false);
        }
    }
}
