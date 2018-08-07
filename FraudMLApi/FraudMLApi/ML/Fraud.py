
from sklearn import model_selection
from sklearn.externals import joblib
from sklearn.neighbors import KNeighborsClassifier
from Model.Retail import Transaction

class FraudCalc():
   
    def __init__(self):
        self.FraudModel = joblib.load('C:\\SeScFRD\\SavedModels\\FraudML.pkl')    

    def calculate(self, transaction):
        mlInput = [transaction.Values]
        arr = self.FraudModel.predict(mlInput)
        fraudVal = arr[0]
        return fraudVal
