with import <nixpkgs> {}; {
    TankDriverEnv = stdenv.mkDerivation {
        name = "TankDriver";
        buildInputs = [ mono libX11 ];
    };
}
