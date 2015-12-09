using UnityEngine;
using System.Collections;

public class Equations : MonoBehaviour {

    private const float DAMAGE_DEALT_TO_DEFENDERS_BY_HORDEATTACK_MODIFIER = 0.01f;
    private const float DAMAGE_DEALT_TO_HORDE_BY_DEFENDING_CITY_MODIFIER = 0.05f;

    public static int GetDefenderCasualityFromHordeAttack(GameObject AttackingHorde)
    {
        //return (int)(AttackingHorde.GetComponent<HordeAttack>().HordeStrength * DAMAGE_DEALT_TO_DEFENDERS_BY_HORDEATTACK_MODIFIER);
        return -1;
    }

    public static int GetHordeCasualityFromDefendingCity(GameObject DefendingCity)
    {
        return (int)( DefendingCity.GetComponent<CityLogic>().DefenderStrength * DAMAGE_DEALT_TO_HORDE_BY_DEFENDING_CITY_MODIFIER);
    }

}
