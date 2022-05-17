var currentQuestion = 0;
var score = 0;
var data;
var apiBaseUrl;


function getConfig() {
    var url = "/api/GetConfig";
    var xhr = new XMLHttpRequest();
    xhr.open("GET", url, true);
    xhr.setRequestHeader("Content-Type", "application/json");

    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            var configdata = JSON.parse(xhr.responseText);
            apiBaseUrl = configdata.apiuri;
            loadQuestions();
        }
        if (xhr.status === 401) {
            console.log("401 : Access is denied");
        }
    };
    xhr.send();
}

function loadQuestions() {

    document.getElementById("questions").style.display = "none";
    document.getElementById("score").style.display = "none";

    var url = apiBaseUrl + "/question";
    var xhr = new XMLHttpRequest();
    xhr.open("GET", url, true);
    xhr.setRequestHeader("Content-Type", "application/json");
    
    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            data = JSON.parse(xhr.responseText);
            renderQuestion();
        }
        if (xhr.status === 401) {
            console.log("401 : Access is denied");
        }
    };
    xhr.send();
}

function renderQuestion() {
    
    document.getElementById("questionText").innerText = data[currentQuestion].text;
    document.getElementById("answer1Text").innerText = data[currentQuestion].answers[0].text;
    document.getElementById("answer2Text").innerText = data[currentQuestion].answers[1].text;
    document.getElementById("answer3Text").innerText = data[currentQuestion].answers[2].text;
    document.getElementById("answer4Text").innerText = data[currentQuestion].answers[3].text;

    document.getElementById("answer1").value = data[currentQuestion].answers[0].isCorrectAnswer;
    document.getElementById("answer2").value = data[currentQuestion].answers[1].isCorrectAnswer;
    document.getElementById("answer3").value = data[currentQuestion].answers[2].isCorrectAnswer;
    document.getElementById("answer4").value = data[currentQuestion].answers[3].isCorrectAnswer;

    document.getElementById("answer1").checked = false;
    document.getElementById("answer2").checked = false;
    document.getElementById("answer3").checked = false;
    document.getElementById("answer4").checked = false;

    document.getElementById("questions").style.display = "";
}

function next() {
    const rbs = document.querySelectorAll('input[name="answer"]');
    let selectedValue;
    for (const rb of rbs) {
        if (rb.checked) {
            selectedValue = rb.value;
            if (selectedValue === "true") {
                score++;
            }
            break;
        }
    }

    if (selectedValue !== undefined) {
        currentQuestion++;
        document.getElementById("progress").style.width = currentQuestion * 20 + "%";
        if (currentQuestion <= 4) {
            renderQuestion()
        }

        if (currentQuestion === 4) {
            nextButton = document.getElementById("nextbutton")
            nextButton.innerText = "Finish";
        }

        if (currentQuestion === 5) {
            showscore();
        }
    }
}

function showscore() {
    document.getElementById("questions").style.display = "none";
    document.getElementById("scoreText").innerText = "Your score is " + score * 20 + "%";
    document.getElementById("score").style.display = "";
}

function retry() {
    score = 0;
    currentQuestion = 0;
    loadQuestions();
}

function requestCert() {
    var certInfo = new Object();
    certInfo.email = document.getElementById("InputEmail").value;
    certInfo.totalScore = score * 20;
    var data = JSON.stringify(certInfo);

    var url = apiBaseUrl + "/score";
    var xhr = new XMLHttpRequest();
    xhr.open("POST", url, true);
    xhr.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    
    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            alert("cert request has been send");
        }
    }
    xhr.send(data);
}