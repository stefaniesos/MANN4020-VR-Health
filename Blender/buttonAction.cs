using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonAction : MonoBehaviour
{
    // Button to control animation
    [SerializeField] private Button button;

    // animator to control
    [SerializeField] private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
         AnimationClip moveClip = animator.runtimeAnimatorController.animationClips[1];
         moveClip.AddEvent(new AnimationEvent()
        {
            // Wait until the clip is over
            time = moveClip.length,
            functionName = "EnableButton"
        });
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        animator.Play("Move");
        button.enabled = false;
    }
    
}
