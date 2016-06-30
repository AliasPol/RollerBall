using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuBehavior : MonoBehaviour {

    private Animator _animator;
    private CanvasGroup _canvasGroup;

    public bool IsOpen
    {
        get
        {
            return _animator.GetBool("IsOpen");
        }
        set
        {
            _animator.SetBool("IsOpen", value);
        }
    }

    public void Awake()
    {
        _animator = GetComponent<Animator>();
        _canvasGroup = GetComponent<CanvasGroup>();


        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            var rect = GetComponent<RectTransform>();

            rect.offsetMax = rect.offsetMin = new Vector2(0, 0);
        }
    }

    public void Update()
    {
        if (!_animator.GetCurrentAnimatorStateInfo(0).IsName("Open"))
        {
            _canvasGroup.blocksRaycasts = _canvasGroup.interactable = false;
        }
        else
        {
            _canvasGroup.blocksRaycasts = _canvasGroup.interactable = true;
        }
    }

}
