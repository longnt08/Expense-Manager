from flask import Flask, request, jsonify
import joblib
import pandas as pd

app = Flask(__name__)
model = joblib.load("trainers/isoforest_model.pkl")

@app.route('/predict', methods = ["POST"])
def detect():
    data = request.json
    df = pd.DataFrame([data])
    prediction = model.predict(df)[0]
    return jsonify({'is_anomaly': int(prediction == -1)})

if __name__ == "__main__":
    app.run(debug = True)