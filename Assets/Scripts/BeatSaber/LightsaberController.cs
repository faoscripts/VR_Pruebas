using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))]
public class LightsaberController : MonoBehaviour
{
    XRGrabInteractable m_InteractableBase;
    Animator m_Animator;

    const string k_AnimTriggerDown = "TriggerDown";
    const string k_AnimTriggerUp = "TriggerUp";
    bool m_TriggerDown;

    protected void Start()
    {
        m_InteractableBase = GetComponent<XRGrabInteractable>();
        m_Animator = GetComponent<Animator>();
        m_InteractableBase.selectExited.AddListener(DroppedGun);
        m_InteractableBase.activated.AddListener(TriggerPulled);
        m_InteractableBase.deactivated.AddListener(TriggerReleased);
        m_TriggerDown = false;
    }

    void TriggerReleased(DeactivateEventArgs args)
    {
        //m_Animator.SetTrigger(k_AnimTriggerUp);
        //m_TriggerDown = false;
    }

    void TriggerPulled(ActivateEventArgs args)
    {
        if(m_TriggerDown){
            m_Animator.SetTrigger(k_AnimTriggerUp);
            m_TriggerDown = false;
        }
        else{
            m_Animator.SetTrigger(k_AnimTriggerDown);
            m_TriggerDown = true;
        }
        
    }

    void DroppedGun(SelectExitEventArgs args)
    {
        // In case the gun is dropped while in use.
        m_Animator.SetTrigger(k_AnimTriggerUp);

        m_TriggerDown = false;
    }

    public void ShootEvent()
    {
    }
}
