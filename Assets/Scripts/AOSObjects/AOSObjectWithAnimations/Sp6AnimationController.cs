using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using Newtonsoft.Json.Bson;
using UnityEngine;
[AosSdk.Core.Utils.AosObject(name: "�������� Sp6")]
public class Sp6AnimationController : AosObjectBase
{
    [SerializeField] private LocationController _locationController;
    private Animator _anim;
    private void Start()
    {
        _anim = GetComponent<Animator>();
    }
    [AosAction(name: "��������� �������� ���� ����")]
    public void PlayLuftPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazLuftPlus");
    }
    [AosAction(name: "��������� �������� ���� �����")]
    public void PlayLuftMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazLuftMinus");
    }
    [AosAction(name: "��������� �������� ����� ����")]
    public void PlayNakatPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazNakatPlus");
    }
    [AosAction(name: "��������� �������� ����� �����")]
    public void PlayNakatMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazNakatMinus");
    }
    [AosAction(name: "��������� �������� ��� ���� ����")]
    public void PlayRegLinePlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazRegLinePlus");
    }
    [AosAction(name: "��������� �������� ��� ���� �����")]
    public void PlayRegLineMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazRegLineMinus");
    }
    [AosAction(name: "��������� �������� ����� ����� �����")]
    public void PlayShiberMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazShiberMinus");
    }
    [AosAction(name: "��������� �������� ����� ����� ����")]
    public void PlayShiberPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazShiberPlus");
    }
    [AosAction(name: "��������� �������� �� ���� �����")]
    public void PlaySvTyagMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazSvTyagMinus");
    }
    [AosAction(name: "��������� �������� �� ���� ����")]
    public void PlaySvTyagPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazSvTyagPlus");
    }
    [AosAction(name: "��������� �������� ������ ������� �����")]
    public void PlaySergaDalMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazSergaDalSvTyagMinus");
    }
    [AosAction(name: "��������� �������� ������ ������� ����")]
    public void PlaySergaDalPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazSergaDalSvTyagPlus");
    }
    [AosAction(name: "��������� �������� ������ ������� ����")]
    public void PlaySergaBlizkPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazSergaBlizkSvTyagPlus");
    }
    [AosAction(name: "��������� �������� ������ ������� �����")]
    public void PlaySergaBlizkMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazSergaBlizkSvTyagMinus");
    }
    [AosAction(name: "��������� �������� ������� ���� ����")]
    public void PlayDlinTyagPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazDlinTyagPlus");
    }
    [AosAction(name: "��������� �������� ������� ���� �����")]
    public void PlayDlinTyagMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazDlinTyagMinus");
    }
    [AosAction(name: "��������� �������� �������� ���� �����")]
    public void PlayKorotkTyagMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazKorotkTyagMinus");
    }
    [AosAction(name: "��������� �������� �������� ���� ����")]
    public void PlayKorotkTyagPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazKorotkTyagPlus");
    }
    [AosAction(name: "��������� �������� ������� 01 �����")]
    public void PlayLin01MinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazLin01Minus");
    }
    [AosAction(name: "��������� �������� ������� 01 ����")]
    public void PlayLin01PlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazLin01Plus");
    }
    [AosAction(name: "��������� �������� ������� 02 ����")]
    public void PlayLin02PlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazLin02Plus");
    }
    [AosAction(name: "��������� �������� ������� 02 �����")]
    public void PlayLin02MinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazLin02Minus");
    }
    [AosAction(name: "��������� �������� ������� ���� ������ �����")]
    public void PlayStrelPlusFrictMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazStrelPlusFrictMinus");
    }
    [AosAction(name: "��������� �������� ������� ����� ������ ����")]
    public void PlayStrelMinusFrictPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        if (InSoundPlace(_locationController.CurrentLocation()))
            SoundPlayer.Instance.PlayRailFriktSound();
        _anim.SetTrigger("otkazStrelMinusFrictPlus");
    }
    [AosAction(name: "��������� �������� ������� ���� ��������� �����")]
    public void PlayStrelPlusEngineMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazStrelPlusEngineMinus");
    }
    [AosAction(name: "��������� �������� ������� ����� ��������� ����")]
    public void PlayStrelMinusEnginePlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazStrelMinusEnginePlus");
    }
    [AosAction(name: "��������� �������� ������ ��������� �����")]
    public void PlayRockEngineMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        if (InSoundPlace(_locationController.CurrentLocation()))
            SoundPlayer.Instance.PlayRailStoneSound();
        _anim.SetTrigger("otkazRockEngineMinus");
      
    }
    [AosAction(name: "��������� �������� ������ ��������� ����")]
    public void PlayRockEnginePlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        if (InSoundPlace(_locationController.CurrentLocation()))
            SoundPlayer.Instance.PlayRailNormSound();
        _anim.SetTrigger("otkazRockEnginePlus");
    }

    [AosAction(name: "��������� �������� ����")]
    public void PlayPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        if (InSoundPlace(_locationController.CurrentLocation()))
            SoundPlayer.Instance.PlayRailNormSound();
        _anim.SetTrigger("plusAnim");
    }
    [AosAction(name: "��������� �������� �����")]
    public void PlayMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        if (InSoundPlace(_locationController.CurrentLocation()))
            SoundPlayer.Instance.PlayRailNormSound();
        _anim.SetTrigger("minusAnim");
    }
    private bool InSoundPlace(string placeName)
    {
        if (placeName == "field" || placeName == "clutch" || placeName == "actuator" ||
            placeName == "e_drive" || placeName == "switch" || placeName == "apron" ||
            placeName == "rod" || placeName == "hollow_left" || placeName == "hollow_right")
            return true;
        else
     return false;
    }
    public void PlayDispetcherAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
    }
}
