using System;
using AosSdk.Core.Utils;
using Newtonsoft.Json.Linq;
using UnityEngine;



[AosSdk.Core.Utils.AosObject(name: "���")]
public class API : AosObjectBase
{
    public Action ShowPlaceEvent;
    public Action ResetMeasureButtonsEvent;
    public Action ShowMenuButtonEvent;
    public Action<float> SetMeasureValueEvent;
    public Action<string> SetTeleportLocationEvent;
    public Action<string> SetNewLocationTextEvent;
    public Action<string> SetLocationEvent;
    public Action<string> SetLocationForFieldCollidersEvent;
    public Action<string> ActivateBackButtonEvent;
    public Action<string> EnableDietButtonsEvent;
    public Action<string> SetTimerTextEvent;
    public Action<string> AddMeasureButtonEvent;
    public Action<string> ReactionEvent;
    public Action<string, string> EnableRactionButtonEvent;
    public Action<string, string, string> ActivateByNameEvent;
    public Action<string, string, string, string> SetMessageTextEvent;
    public Action<string, string, string> SetResultTextEvent;
    public Action<string, string, string> ShowSticker;
    public Action<string, string, string> ResultNameTextButtonEvent;
    public Action<string, string> ShowExitTextEvent;
    public Action<string, string> ResultNameTextButtonSingleEvent;
    public Action<string, string, string> ShowMenuTextEvent;
    public Action<string, string, string, string> SetStartTextEvent;

    [AosEvent(name: "����������� ������")]
    public event AosEventHandlerWithAttribute EndTween;
    [AosEvent(name: "���� �� ������ �����")]
    public event AosEventHandlerWithAttribute navAction;
    [AosEvent(name: "��������� ���������")]
    public event AosEventHandlerWithAttribute OnMeasure;
    [AosEvent(name: "��������� ���������")]
    public event AosEventHandlerWithAttribute OnReason;
    [AosEvent(name: "������� ����")]
    public event AosEventHandler OnMenu;
    public void Teleport([AosParameter("������ ������� ��� �����������")] string location)
    {
        SetTeleportLocationEvent?.Invoke(location);
        EndTween?.Invoke(location);
    }
    [AosAction(name: "������ ����� �����������")]
    public void showWelcome(JObject welcome, JObject faultInfo, JObject nav)
    {
        string headerText = welcome.SelectToken("name").ToString();
        string commentText = welcome.SelectToken("text").ToString();
        string headerFaultText = faultInfo.SelectToken("name").ToString();
        string commentFaultText = faultInfo.SelectToken("text").ToString();
        SetStartTextEvent?.Invoke(headerText, commentText, headerFaultText, commentFaultText);
        //OnSetTeleportLocation?.Invoke("start");
    }

    public void OnInvokeNavAction(string value)
    {
        navAction.Invoke(value);
    }
    public void showLearningSticker(JObject sticker)
    {
        Debug.Log(sticker.ToString());
        string header = "";
        string penalty = "";
        string text = "";
        header = sticker.SelectToken("header").ToString();
        penalty = sticker.SelectToken("penalty").ToString();
        var textmin = sticker.SelectToken("text");
        if (textmin != null)
        {
            text = sticker.SelectToken("text").ToString();
        }
        ShowSticker?.Invoke(header, penalty, text);



    }
    [AosAction(name: "�������� �����")]
    public void showPlace(JArray places, JObject nav)
    {
        ShowPlaceEvent?.Invoke();
        foreach (JObject item in places)
        {

            var pl = item.SelectToken("place");
            if (pl != null)
            {
               
                string location = pl.SelectToken("apiId").ToString();
                if (location != null)
                {
                    SetLocationEvent?.Invoke(location);                 
                }


                var loc = pl.SelectToken("name");
                if (loc != null)
                    SetNewLocationTextEvent?.Invoke(loc.ToString());

            }
            var points = item.SelectToken("points");
            if (points != null)
            {
                foreach (JObject point in points)
                {
                    if (point != null)
                    {

                        var temp = point.SelectToken("apiId");
                        var id = "";
                        var name = "";
                        var time = "";
                        if (temp != null)
                        {
                            id = temp.ToString();
                            name = point.SelectToken("name").ToString();
                        }
                        var timeText = point.SelectToken("result");
                        if (timeText != null)
                        {
                            var timeToShow = timeText.SelectToken("tm");
                            if (timeToShow != null)
                            {
                                time = timeText.SelectToken("tm").ToString();
                            }
                        }
                        ActivateByNameEvent?.Invoke(id, name, time);
                    }

                }
            }
        }

        if (nav.SelectToken("back") != null && nav.SelectToken("back").SelectToken("action") != null && nav.SelectToken("back").SelectToken("action").ToString() != String.Empty)
        {
            ActivateBackButtonEvent?.Invoke(nav.SelectToken("back").SelectToken("action").ToString());
        }
    }
    [AosAction(name: "�������� �����")]
    public void updatePlace(JArray data)
    {
        Debug.Log("Enter UpdatePlace");
        foreach (JObject item in data)
        {
            var temp = item.SelectToken("points");
            if (temp != null)
            {
                EnableDietButtonsEvent(null);
                if (temp is JArray)
                {
                    foreach (var temp2 in temp)
                    {
                        string buttonName = temp2.SelectToken("apiId").ToString();
                        EnableDietButtonsEvent(buttonName);
                    }
                }
            }
        }
    }


    [AosAction(name: "�������� �������")]
    public void showReaction(JObject info, JObject nav)
    {
        Debug.Log("ShowReaction");
        if (info.SelectToken("text") != null)
        {
            var reactionText = info.SelectToken("text").ToString();
            ReactionEvent?.Invoke(reactionText);
        }
    }

    [AosAction(name: "�������� ���������")]
    public void showMessage(JObject info, JObject nav)
    {
        Debug.Log("MESSAGE " + info.ToString());
       
        string footerText = "";
        var header = info.SelectToken("header");
        var footer = info.SelectToken("footer");
        var comment = info.SelectToken("text");
        var alarm = info.SelectToken("alarm");
        if (header != null && footer != null && comment != null && alarm != null)
        {
            Debug.Log("1");
            footerText = HtmlToText.Instance.HTMLToTextReplace(footer.ToString());
            string commentText = HtmlToText.Instance.HTMLToTextReplace(comment.ToString());
            string headText = header.ToString();
            string alarmImg = alarm.ToString();
            SetMessageTextEvent?.Invoke(headText, footerText, commentText, alarmImg);
        }
        else if (header != null && comment != null && alarm != null)
        {
            Debug.Log("2");
            string commentText = HtmlToText.Instance.HTMLToTextReplace(comment.ToString());
            string headText = header.ToString();
            string alarmImg = alarm.ToString();
            SetMessageTextEvent?.Invoke(headText, footerText, commentText, alarmImg);
        }
        else if (comment != null)
        {
            string headText = "";
            Debug.Log("3");
            string commentText = HtmlToText.Instance.HTMLToTextReplace(comment.ToString());
            footerText = "";
            var heade = info.SelectToken("header");
            if (heade != null)
            {
                headText = heade.ToString();
            }
           
            string alarmImg = "none";
            SetMessageTextEvent?.Invoke(headText, footerText, commentText, alarmImg);
        }

    }
    [AosAction(name: "�������� ���������")]
    public void showResult(JObject info, JObject nav)
    {
        string resultText = "";
        Debug.Log("RESULT " + info.ToString());
        string headText = info.SelectToken("name").ToString();
        string commentText = HtmlToText.Instance.HTMLToTextReplace(HtmlToText.Instance.HTMLToTextReplace(info.SelectToken("text").ToString()));
        string evalText = HtmlToText.Instance.HTMLToTextReplace(info.SelectToken("eval").ToString());
        SetResultTextEvent?.Invoke(headText, commentText, evalText);
        var result = info.SelectToken("result");


        if (result != null)
        {
            foreach (JObject item in result)
            {
                resultText = "";
                var name = item.SelectToken("name").ToString();
                var penalty = item.SelectToken("penalty").ToString();
                var msg = item.SelectToken("msg");
                if (msg == null)
                {
                    ResultNameTextButtonSingleEvent?.Invoke(name, penalty);
                }
                else
                {

                    foreach (var item2 in msg)
                    {
                        var message2 = item2.SelectToken("msg");
                        var name2 = item2.SelectToken("name");
                        if (message2 != null && name2 != null)
                        {
                            resultText += name2.ToString() + message2.ToString();
                        }
                        else
                        {
                            resultText += HtmlToText.Instance.HTMLToTextReplace(item2.ToString()) + "\n";
                        }
                    }
                    ResultNameTextButtonEvent?.Invoke(name, penalty, resultText);
                }

            }
        }

    }
    [AosAction(name: "�������� �����")]
    public void showPoints(string info, JArray data)
    {
        Debug.Log(data.ToString());

        EnableRactionButtonEvent?.Invoke(null, null);
        foreach (JObject item in data)
        {
            if (item == null)
                return;
            if (item.SelectToken("tool") != null && item.SelectToken("name") != null)
            {

                if (item.SelectToken("tool").ToString() == "eye")
                {
                    string eye = item.SelectToken("tool").ToString();
                    string text = item.SelectToken("name").ToString();
                    EnableRactionButtonEvent?.Invoke(eye, text);
                }
                if (item.SelectToken("tool").ToString() == "hand")
                {
                    string hand = item.SelectToken("tool").ToString();
                    string text = item.SelectToken("name").ToString();
                    EnableRactionButtonEvent?.Invoke(hand, text);
                }
                if (item.SelectToken("tool").ToString() == "tool")
                {
                    string tool = item.SelectToken("tool").ToString();
                    string text = item.SelectToken("name").ToString();
                    EnableRactionButtonEvent?.Invoke(tool, text);
                }
            }

            else if (item.SelectToken("apiId") != null)
            {
                string buttonName = item.SelectToken("apiId").ToString();
                EnableDietButtonsEvent?.Invoke(buttonName);
                Debug.Log("RADIO "+ buttonName);
            }
        }
    }

    [AosAction(name: "�������� �������")]
    public void showTime(string time)
    {
        SetTimerTextEvent?.Invoke(time);
    }
    [AosAction(name: "�������� ����� ���������")]
    public void showMeasure(JObject data)
    {
        
        ResetMeasureButtonsEvent?.Invoke();
        var points = data.SelectToken("points");
        if(points != null)
        {
            foreach (JObject item in points)
            {
                var tmpArray = item.SelectToken("points");
                if (tmpArray != null && tmpArray is JArray)
                {
                    foreach (JObject item2 in tmpArray)
                    {
                        string butonName = item2.SelectToken("apiId").ToString();
                        AddMeasureButtonEvent?.Invoke(butonName);
                    }
                }
            }
        }
        
    }
    [AosAction(name: "�������� ����� ���������")]
    public void showMeasureResult(JObject result, JObject nav)
    {
        Debug.Log("in showFaultInfo Measure Result");
        if (result.SelectToken("result") != null)
        {
            float measureValue = float.Parse(result.SelectToken("result").ToString());
            SetMeasureValueEvent?.Invoke(measureValue);
            Debug.Log("in showFaultInfo Measure Result " + measureValue);
        }
    }
    [AosAction(name: "�������� ����")]
    public void showMenu(JObject data)
    {
        
      
        if (data.SelectToken("algs") != null && data.SelectToken("algs").ToString() != String.Empty) { ShowMenuButtonEvent?.Invoke(); }
        string exitSureText = data.SelectToken("exitInfo").SelectToken("quest").ToString();
       
        var fltInfo = data.SelectToken("fltInfo");
        if (fltInfo != null)
        {
            string headtext = fltInfo.SelectToken("name").ToString();
            string commentText = fltInfo.SelectToken("text").ToString();
            ShowMenuTextEvent?.Invoke(headtext, commentText, exitSureText);
        }
        var exitInfo = data.SelectToken("exitInfo");
        if (exitInfo.SelectToken("text") != null && exitInfo.SelectToken("warn") != null)
        {
            string exitText = HtmlToText.Instance.HTMLToTextReplace(exitInfo.SelectToken("text").ToString());
                string warntext = HtmlToText.Instance.HTMLToTextReplace(exitInfo.SelectToken("warn").ToString());
                ShowExitTextEvent?.Invoke(exitText, warntext);
        }
       
    }
    public void InvokeOnMeasure(string text)
    {
        OnMeasure?.Invoke(text);
    }
    public void OnReasonInvoke(string name)
    {
        OnReason?.Invoke(name);
    }
    public void OnMenuInvoke()
    {
        OnMenu?.Invoke();
    }
    public void InvokeEndTween(string location)
    {
        EndTween?.Invoke(location);
    }
}
