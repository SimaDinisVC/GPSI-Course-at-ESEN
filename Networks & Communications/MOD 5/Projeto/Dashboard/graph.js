(() => {
    // Graphs - this code puts the data into the Canvas
    const ctx = document.getElementById('myChart');

    const myChart = new Chart(ctx, {
        type: 'line',
        data: {
          labels: [
            'Segunda-Feira',
            'Terça-Feira',
            'Quarta-Feira',
            'Quinta-Feira',
            'Sexta-Feira',
            'Sábado',
            'Domingo'
          ],
          datasets: [{
            data: [
            1365,
            784,
            1537,
            552,
            921,
            2051,
            1976
            ],
            lineTension: 0,
            backgroundColor: 'transparent',
            borderColor: '#007bff',
            borderWidth: 4,
            pointBackgroundColor: '#007bff'
          }]
        },
        options: {
            scales: {
                y: {
                    ticks: {
                        color: 'white'
                    },
                    grid: {
                        color: '#FFFFFF3C'
                    }
                },
                x: {
                    ticks: {
                        color: 'white'
                    },
                    grid: {
                        color: '#FFFFFF3C'
                    }
                }
            },
            plugins: {
                legend: {
                    display: false
                },
                tooltip: {
                    boxPadding: 3
                }
            }
        }
    })
})()