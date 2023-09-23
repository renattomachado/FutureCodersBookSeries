/**
 * Text in the book ;D
 */
class Program {
    static main() {
        const planets = [
            "Mercúrio",
            "Vênus",
            "Terra",
            "Marte",
            "Júpter",
            "Saturno",
            "Urano",
            "Netuno"
        ];
        
        const targetPlanet = prompt("Informe um nome para descobrir se é planeta");
        const found = Program.searchPlanets(planets, targetPlanet);
        
        console.log(`${targetPlanet} é um planeta? ${found}`);
    }

    static searchPlanets(planets, target, index = 0) {
        if (planets.length === 0) {
            return false;
        }

        if (planets[index] === target) {
            return true;
        }

        if (index < planets.length - 1) {
            return Program.searchPlanets(planets, target, index + 1);
        }

        return false;
    }
}

Program.main();
