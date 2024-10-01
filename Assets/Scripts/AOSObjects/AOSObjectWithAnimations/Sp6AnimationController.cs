using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using Newtonsoft.Json.Bson;
using UnityEngine;
[AosSdk.Core.Utils.AosObject(name: "Анимация Sp6")]
public class Sp6AnimationController : AosObjectBase
{
    [SerializeField] private LocationController _locationController;
    private Animator _anim;
    private void Start()
    {
        _anim = GetComponent<Animator>();
    }
    [AosAction(name: "Проиграть анимацию люфт плюс")]
    public void PlayLuftPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazLuftPlus");
    }
    [AosAction(name: "Проиграть анимацию люфт минус")]
    public void PlayLuftMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazLuftMinus");
    }
    [AosAction(name: "Проиграть анимацию накат плюс")]
    public void PlayNakatPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazNakatPlus");
    }
    [AosAction(name: "Проиграть анимацию накат минус")]
    public void PlayNakatMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazNakatMinus");
    }
    [AosAction(name: "Проиграть анимацию рег лайн плюс")]
    public void PlayRegLinePlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazRegLinePlus");
    }
    [AosAction(name: "Проиграть анимацию рег лайн минус")]
    public void PlayRegLineMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazRegLineMinus");
    }
    [AosAction(name: "Проиграть анимацию Отказ шибер минус")]
    public void PlayShiberMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazShiberMinus");
    }
    [AosAction(name: "Проиграть анимацию Отказ шибер плюс")]
    public void PlayShiberPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazShiberPlus");
    }
    [AosAction(name: "Проиграть анимацию СВ Тяги минус")]
    public void PlaySvTyagMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazSvTyagMinus");
    }
    [AosAction(name: "Проиграть анимацию СВ Тяги плюс")]
    public void PlaySvTyagPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazSvTyagPlus");
    }
    [AosAction(name: "Проиграть анимацию Серьги дальней минус")]
    public void PlaySergaDalMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazSergaDalSvTyagMinus");
    }
    [AosAction(name: "Проиграть анимацию Серьги дальней плюс")]
    public void PlaySergaDalPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazSergaDalSvTyagPlus");
    }
    [AosAction(name: "Проиграть анимацию Серьги ближней плюс")]
    public void PlaySergaBlizkPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazSergaBlizkSvTyagPlus");
    }
    [AosAction(name: "Проиграть анимацию Серьги ближней минус")]
    public void PlaySergaBlizkMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazSergaBlizkSvTyagMinus");
    }
    [AosAction(name: "Проиграть анимацию Длинной тяги плюс")]
    public void PlayDlinTyagPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazDlinTyagPlus");
    }
    [AosAction(name: "Проиграть анимацию Длинной тяги минус")]
    public void PlayDlinTyagMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazDlinTyagMinus");
    }
    [AosAction(name: "Проиграть анимацию Короткой тяги минус")]
    public void PlayKorotkTyagMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazKorotkTyagMinus");
    }
    [AosAction(name: "Проиграть анимацию Короткой тяги плюс")]
    public void PlayKorotkTyagPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazKorotkTyagPlus");
    }
    [AosAction(name: "Проиграть анимацию Линейка 01 минус")]
    public void PlayLin01MinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazLin01Minus");
    }
    [AosAction(name: "Проиграть анимацию Линейка 01 плюс")]
    public void PlayLin01PlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazLin01Plus");
    }
    [AosAction(name: "Проиграть анимацию Линейка 02 плюс")]
    public void PlayLin02PlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazLin02Plus");
    }
    [AosAction(name: "Проиграть анимацию Линейка 02 минус")]
    public void PlayLin02MinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazLin02Minus");
    }
    [AosAction(name: "Проиграть анимацию Стретка плюс трение минус")]
    public void PlayStrelPlusFrictMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazStrelPlusFrictMinus");
    }
    [AosAction(name: "Проиграть анимацию Стретка минус трение плюс")]
    public void PlayStrelMinusFrictPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        if (InSoundPlace(_locationController.CurrentLocation()))
            SoundPlayer.Instance.PlayRailFriktSound();
        _anim.SetTrigger("otkazStrelMinusFrictPlus");
    }
    [AosAction(name: "Проиграть анимацию Стретка плюс двигатель минус")]
    public void PlayStrelPlusEngineMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazStrelPlusEngineMinus");
    }
    [AosAction(name: "Проиграть анимацию Стретка минус двигатель плюс")]
    public void PlayStrelMinusEnginePlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        _anim.SetTrigger("otkazStrelMinusEnginePlus");
    }
    [AosAction(name: "Проиграть анимацию Камень двигатель минус")]
    public void PlayRockEngineMinusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        if (InSoundPlace(_locationController.CurrentLocation()))
            SoundPlayer.Instance.PlayRailStoneSound();
        _anim.SetTrigger("otkazRockEngineMinus");
      
    }
    [AosAction(name: "Проиграть анимацию Камень двигатель плюс")]
    public void PlayRockEnginePlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        if (InSoundPlace(_locationController.CurrentLocation()))
            SoundPlayer.Instance.PlayRailNormSound();
        _anim.SetTrigger("otkazRockEnginePlus");
    }

    [AosAction(name: "Проиграть анимацию плюс")]
    public void PlayPlusAnim()
    {
        StrelkaAOS.StrelkaChangedEvent?.Invoke();
        if (InSoundPlace(_locationController.CurrentLocation()))
            SoundPlayer.Instance.PlayRailNormSound();
        _anim.SetTrigger("plusAnim");
    }
    [AosAction(name: "Проиграть анимацию минус")]
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
