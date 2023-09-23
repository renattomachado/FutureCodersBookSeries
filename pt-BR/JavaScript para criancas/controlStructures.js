/**
  * Text in the book ;D
  */
class ControlStructures {
    static sample() {
        let planetIsLikeEarth = false;
        let findNewPlanet = false;

        while (!findNewPlanet) {
            const userInput = prompt("O planeta encontrado é parecido com a Terra? (Digite SIM ou NÃO)").toUpperCase();
            planetIsLikeEarth = userInput === "SIM";

            if (planetIsLikeEarth) {
                findNewPlanet = true;
                console.log("Huston, já não temos mais um problema!");
            }
        }
    }
}

ControlStructures.sample();
