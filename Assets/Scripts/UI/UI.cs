using UnityEngine;

public class UI : MonoBehaviour
{
    // UI.SetActive로 게임오브젝트의 SetActive에 바로접근
    public void SetActive(bool _bool)
    {
        gameObject.SetActive(_bool);
    }
}
