using UnityEngine;
using UnityEngine.UI;

public class UIAnimatorController : MonoBehaviour
{
    public Animator panelAnimator; // 사이드바 애니메이터
    public Animator mainPanelAnimator; // 메인 화면 애니메이터
    public Button openButton; // 사이드바 열기 버튼
    public Button closeButton; // 사이드바 닫기 버튼

    void Start()
    {
        openButton.onClick.AddListener(OpenSidebar);
        closeButton.onClick.AddListener(CloseSidebar);
    }
    // 사이드바 열기
    void OpenSidebar()
    {
        panelAnimator.SetTrigger("Show");
        mainPanelAnimator.SetTrigger("Shrink");
        openButton.gameObject.SetActive(false);
        closeButton.gameObject.SetActive(true);
    }
    // 사이드바 닫기
    void CloseSidebar()
    {
        panelAnimator.SetTrigger("Hide");
        mainPanelAnimator.SetTrigger("Expand");
        openButton.gameObject.SetActive(true);
        closeButton.gameObject.SetActive(false);
    }
}
