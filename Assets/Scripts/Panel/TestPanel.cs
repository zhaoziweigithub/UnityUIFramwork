﻿using UnityEngine;
using System.Collections;
using DG.Tweening;

public class TestPanel : BasePanel {

    private CanvasGroup canvasGroup;

    void Start()
    {
        base.Start();
        //if (canvasGroup == null) canvasGroup = GetComponent<CanvasGroup>();
    }

    public override void ReceiveMessage(UIPanelType type, object par1 = null, object par2 = null)
    {

    }

    public override void OnEnter()
    {
        if (canvasGroup == null) canvasGroup = GetComponent<CanvasGroup>();
        if (canvasGroup != null)
        {
            canvasGroup.alpha = 0;
            canvasGroup.blocksRaycasts = true;

            canvasGroup.DOFade(1, .5f);
        }
        
    }

    public override void OnExit()
    {
        if (canvasGroup != null)
        {
            canvasGroup.alpha = 1;
            canvasGroup.blocksRaycasts = false;
            canvasGroup.DOFade(0, .5f);
        }

         
    }

    //public void OnClosePanel()
    //{
    //    UIManager.Instance.PopPanel();
    //}

}
