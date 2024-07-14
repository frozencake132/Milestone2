using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public TMP_Text PlayerName;

    void Start()
    {
        PlayerName.text = PlayerData.Instance.PlayerName();
    }
}
