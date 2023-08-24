using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public enum RCP
{
    rock,
    scissor,
    paper
}
public class RockScissorPaper : MonoBehaviour
{
    private float timeLimit = 3;
    [SerializeField] private TextMeshProUGUI countText;
    [SerializeField] private Button[] buttons;

    private RCP rcpState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        countText.text = Timer() == 0 ? " " : $"{Timer()}";
        ShowUI();
    }

    private int Timer()
    {
        float curruntTime = Time.deltaTime;
        timeLimit -= curruntTime;
        return (int)timeLimit > 3? 0 : (int)timeLimit;
    }

    private void ShowUI()
    {
        if(Timer() == 0)
        {

        }
    }

    #region UI-Button
    public void Rock()
    {
        rcpState = RCP.rock;
    }
    public void Scissor()
    {
        rcpState = RCP.scissor;
    }
    public void Papper()
    {
        rcpState = RCP.paper;
    }
    #endregion
}
