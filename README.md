## Silver-Oni-Mods
Mods for Oxygen Not Included
Repo configuration and utilities forked from [Sgt_Imalas](https://github.com/Sgt-Imalas/Sgt_Imalas-Oni-Mods)

## How to build this Repository
1. clone/download repository and open it in visual studio
2. make a copy of the `Directory.Build.props.default` file and name it `Directory.Build.props.user`, then adjust the variables "ModFolder" and "GameLibsFolder" inside of the copy to reference your local dev folder and your game folder. This will relink all references to the game assemblies.
3. run "clean" on the 1_CycleComma project. This runs the publicise task to create publicised versions of the game assembly (all variables and functions are made public). If it does not work, try restoring NuGet packages on that mod.
4. Done. All mods should now be able to compile properly and be copied to the dev-folder on completion. A project template file is included with "UpdatedOniTemplate.zip".


## Mods in this Repository
My mods can be found on the [Steam Workshop]().

For direct downloads, there are both [nightly builds]() and [full releases]().


Downloads for older ONI versions can also be found in [releases]().
