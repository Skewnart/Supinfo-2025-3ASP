document.getElementById("fetchData").addEventListener("click", async () => {
    const output = document.getElementById("output");
    output.textContent = "Chargement...";

    try {
        const response = await fetch("http://localhost:5215/api/classrooms", {
            headers: {
                "Accept": "application/json"
            }
        });

        if (!response.ok) {
            throw new Error(`Erreur HTTP : ${response}`);
        }

        const data = await response.json();
        output.textContent = JSON.stringify(data, null, 2);
    } catch (error) {
        output.innerHTML = `Erreur : ${error.message}<br>Vérifiez la console.`;
    }
});