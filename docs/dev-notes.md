# Development Notes

## Local Database Migration Scripts

- `Add-Migration -Name Init -Project CatCoven.MewMewMaterials -StartupProject CatCoven.MewMewMaterials -Context MaterialsDbContext`
- `Update-Database -Project CatCoven.MewMewMaterials -StartupProject CatCoven.MewMewMaterials -Context MaterialsDbContext`

- `Add-Migration -Name Init -Project CatCoven.PurrfectPotions -StartupProject CatCoven.PurrfectPotions -Context PotionsDbContext`
- `Update-Database -Project CatCoven.PurrfectPotions -StartupProject CatCoven.PurrfectPotions -Context PotionsDbContext`

- `Add-Migration -Name Init -Project CatCoven.KittenCharmSpells -StartupProject CatCoven.KittenCharmSpells -Context SpellsDbContext`
- `Update-Database -Project CatCoven.KittenCharmSpells -StartupProject CatCoven.KittenCharmSpells -Context SpellsDbContext`
