using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHands : MonoBehaviour
{
    public InputActionProperty pinchingInput;
    public InputActionProperty gripInput;
    Animator handAnimator;
    // Start is called before the first frame update
    void Start()
    {
        handAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchingInput.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);
        float gripValue = gripInput.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
        
    }
}
