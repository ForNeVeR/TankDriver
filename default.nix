with import <nixpkgs> {}; {
    TankDriverEnv = stdenv.mkDerivation {
        name = "TankDriver";
        buildInputs = [ mesa mono46 dotnetPackages.Nuget xorg.libX11 ];
        LD_LIBRARY_PATH="${xorg.libX11}/lib:${mesa}/lib";
    };
}
