var oggettoGrafico=null;

function init(){
    grafico1();
    grafico2();
    grafico3();
}


function grafico1(){
  const labels = ["1","2","3","4","5","6","7","8","9","10"];
  const valore1 = [];
  const valore2 = [];

  for(let i = 0; i<labels.length;i++)
  {
      valore1.push(Math.random()*800);
      valore2.push(Math.random()*40);
  }

  const data = {
      labels: labels,
      datasets: [{
        label: 'Linea 1',
        backgroundColor: 'rgb(255, 0, 0)',
        borderColor: 'rgb(255, 0, 0)',
        yAxesGroup: 'A',
        data: valore1,
      },
      {
        label: 'Linea 2',
        backgroundColor: 'rgb(0,0,255)',
        borderColor: 'rgb(0,0,255)',
        yAxesGroup: 'B',
        data: valore2,
      }]
  };

  const config = {
      type: 'line',
      data: data,
      options: { yAxes: [
        {
          name: 'A',
          type: 'linear',
          position: 'left',
          scalePositionLeft: true,
          ticks: {
            max: 800,
            min: 0
          }
        },
        {
          name: 'B',
          type: 'linear',
          position: 'right',
          scalePositionLeft: false,
          ticks: {
            max: 40,
            min: 0
          }
        }
      ]}
  };

  oggettoGrafico = new Chart(
      document.getElementById('myChart'),
      config
  );
}



function grafico2(){
  const labels = ["1","2","3","4","5","6","7","8","9","10","11","12","13","14","15","16","17","18","19","20"];
  const valore1 = [];

  for(let i = 0; i<labels.length;i++)
  {
      valore1.push(Math.log(i));
  }

  const data = {
      labels: labels,
      datasets: [{
        label: 'Linea 1',
        backgroundColor: 'red',
        borderColor: 'red',
        data: valore1,

           
      }]
  };

  const config = {
      type: 'scatter',
      data: data,
      options: {}
  };

  oggettoGrafico = new Chart(
      document.getElementById('myChart2'),
      config
  );
}



function grafico3(){
  const labels = ['1'];
  const valore1 = [500, 300];

  const data = {
      labels: labels,
      datasets: [{
        label: 'Linea 1',
        backgroundColor: ['blue',
        'green'],
        borderColor: ['black',
        'red'],
        data: valore1,
      }]
  };


  const config = {
      type: 'doughnut',
      data: data,
      options: {
        rotation: -90,
        circumference: 180,}
  };

  oggettoGrafico = new Chart(
      document.getElementById('myChart3'),
      config
  );
}

