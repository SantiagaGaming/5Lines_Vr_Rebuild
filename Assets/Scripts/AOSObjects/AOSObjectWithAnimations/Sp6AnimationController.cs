using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
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
    [AosAction(name: "��������� �������� ����� ����� �����")]
    public void PlayShiberMinusAnim()
    {
        _anim.SetTrigger("otkazShiberMinus");
    }
    [AosAction(name: "��������� �������� ����� ����� ����")]
    public void PlayShiberPlusAnim()
    {
        _anim.SetTrigger("otkazShiberPlus");
    }
    [AosAction(name: "��������� �������� �� ���� �����")]
    public void PlaySvTyagMinusAnim()
    {
        _anim.SetTrigger("otkazSvTyagMinus");
    }
    [AosAction(name: "��������� �������� �� ���� ����")]
    public void PlaySvTyagPlusAnim()
    {
        _anim.SetTrigger("otkazSvTyagPlus");
    }
    [AosAction(name: "��������� �������� ������ ������� �����")]
    public void PlaySergaDalMinusAnim()
    {
        _anim.SetTrigger("otkazSergaDalSvTyagMinus");
    }
    [AosAction(name: "��������� �������� ������ ������� ����")]
    public void PlaySergaDalPlusAnim()
    {
        _anim.SetTrigger("otkazSergaDalSvTyagPlus");
    }
    [AosAction(name: "��������� �������� ������ ������� ����")]
    public void PlaySergaBlizkPlusAnim()
    {
        _anim.SetTrigger("otkazSergaBlizkSvTyagPlus");
    }
    [AosAction(name: "��������� �������� ������ ������� �����")]
    public void PlaySergaBlizkMinusAnim()
    {
        _anim.SetTrigger("otkazSergaBlizkSvTyagMinus");
    }
    [AosAction(name: "��������� �������� ������� ���� ����")]
    public void PlayDlinTyagPlusAnim()
    {
        _anim.SetTrigger("otkazDlinTyagPlus");
    }
    [AosAction(name: "��������� �������� ������� ���� �����")]
    public void PlayDlinTyagMinusAnim()
    {
        _anim.SetTrigger("otkazDlinTyagMinus");
    }
    [AosAction(name: "��������� �������� �������� ���� �����")]
    public void PlayKorotkTyagMinusAnim()
    {
        _anim.SetTrigger("otkazKorotkTyagMinus");
    }
    [AosAction(name: "��������� �������� �������� ���� ����")]
    public void PlayKorotkTyagPlusAnim()
    {
        _anim.SetTrigger("otkazKorotkTyagPlus");
    }
    [AosAction(name: "��������� �������� ������� 01 �����")]
    public void PlayLin01MinusAnim()
    {
        _anim.SetTrigger("otkazLin01Minus");
    }
    [AosAction(name: "��������� �������� ������� 01 ����")]
    public void PlayLin01PlusAnim()
    {
        _anim.SetTrigger("otkazLin01Plus");
    }
    [AosAction(name: "��������� �������� ������� 02 ����")]
    public void PlayLin02PlusAnim()
    {
        _anim.SetTrigger("otkazLin02Plus");
    }
    [AosAction(name: "��������� �������� ������� 02 �����")]
    public void PlayLin02MinusAnim()
    {
        _anim.SetTrigger("otkazLin02Minus");
    }
    [AosAction(name: "��������� �������� ������� ���� ������ �����")]
    public void PlayStrelPlusFrictMinusAnim()
    {
        _anim.SetTrigger("otkazStrelPlusFrictMinus");
    }
    [AosAction(name: "��������� �������� ������� ����� ������ ����")]
    public void PlayStrelMinusFrictPlusAnim()
    {
        if (InSoundPlace(_locationController.GetLocationName()))
            SoundPlayer.Instance.PlayRailFriktSound();
        _anim.SetTrigger("otkazStrelMinusFrictPlus");
    }
    [AosAction(name: "��������� �������� ������� ���� ��������� �����")]
    public void PlayStrelPlusEngineMinusAnim()
    {
        _anim.SetTrigger("otkazStrelPlusEngineMinus");
    }
    [AosAction(name: "��������� �������� ������� ����� ��������� ����")]
    public void PlayStrelMinusEnginePlusAnim()
    {
        _anim.SetTrigger("otkazStrelMinusEnginePlus");
    }
    [AosAction(name: "��������� �������� ������ ��������� �����")]
    public void PlayRockEngineMinusAnim()
    {
        if (InSoundPlace(_locationController.GetLocationName()))
            SoundPlayer.Instance.PlayRailStoneSound();
        _anim.SetTrigger("otkazRockEngineMinus");
      
    }
    [AosAction(name: "��������� �������� ������ ��������� ����")]
    public void PlayRockEnginePlusAnim()
    {
        if (InSoundPlace(_locationController.GetLocationName()))
            SoundPlayer.Instance.PlayRailNormSound();
        _anim.SetTrigger("otkazRockEnginePlus");
    }

    [AosAction(name: "��������� �������� ����")]
    public void PlayPlusAnim()
    {
        if (InSoundPlace(_locationController.GetLocationName()))
            SoundPlayer.Instance.PlayRailNormSound();
        _anim.SetTrigger("plusAnim");
    }
    [AosAction(name: "��������� �������� �����")]
    public void PlayMinusAnim()
    {
        if (InSoundPlace(_locationController.GetLocationName()))
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
}
