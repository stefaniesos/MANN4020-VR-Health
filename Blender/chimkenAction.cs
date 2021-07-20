using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chimkenAction : MonoBehaviour
{
    [SerializeField]
    private Button button;

    void EnableButton()
    {
        button.enabled = true;
    }
}
