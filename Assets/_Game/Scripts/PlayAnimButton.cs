using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimButton : MonoBehaviour {
    public Animator anim;
    [SerializeField] private string AnimTrigger;

    public void PlayNextAnim() {
        anim.SetTrigger(AnimTrigger);
    }
}
