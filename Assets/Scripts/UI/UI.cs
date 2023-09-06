using UnityEngine;

public class UI : MonoBehaviour
{
    public virtual void OnUI()
    {
        gameObject.SetActive(true);
    }

    public virtual void OffUI()
    {
        gameObject.SetActive(false);
    }
}
