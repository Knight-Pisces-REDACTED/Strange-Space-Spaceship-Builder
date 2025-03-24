public class WeaponClass {

    public string name;
    public Techs reqTech;
    public WeaponSupertypes type;
    public double damage;
    public double range;
    public double accuracy;
    public double weight;
    public double cost;
    public double falloff;


    public WeaponClass(string weaponName, double weaponDamage, double weaponRange, double baseAccuracy, double baseWeight, double baseCost, Techs tech, double falloffRate, WeaponSupertypes baseType){
        name = weaponName;
        reqTech = tech;
        type = baseType; 
        weight = baseWeight;
        cost = baseCost;
        accuracy = baseAccuracy;
        range = weaponRange;
        damage = weaponDamage;
        falloff = falloffRate;
    }

}