using System.Threading;
using UnityEngine;

public class DistanceTrigger : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float activationDistance = 3.0f;
    [SerializeField] private float resetDelay = 10.0f;
    [SerializeField] private string triggerName = "NextAnim";
    private float timer;

    private Animator anim;

    private void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(this.transform.position, target.position);

        if(distance < activationDistance && timer <= 0)
        {
            Activate();
        }

        if(timer > 0) timer -= Time.deltaTime;
    }

    private void Activate()
    {
        anim.SetTrigger(triggerName);
        timer = resetDelay;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position, activationDistance);
    }
}
