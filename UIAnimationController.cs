using UnityEngine;
using UnityEngine.UI;

public class UIAnimatorController : MonoBehaviour
{
    public Animator panelAnimator;
    public Button showButton;
    public Button hideButton;

    void Start()
    {
        showButton.onClick.AddListener(() => panelAnimator.SetTrigger("Show"));
        hideButton.onClick.AddListener(() => panelAnimator.SetTrigger("Hide"));
    }
}
