
import psycopg2
from sqlalchemy import *
from sklearn import model_selection
from sklearn.externals import joblib
from sklearn.neighbors import KNeighborsClassifier
import pandas as pd
import numpy as np

#read the table to dataFrame
engine = create_engine('postgresql://postgres:Qwe12345@localhost:5432/FRD')
df = pd.read_sql_query('select * from "TransactionsWithFraud"',con=engine)

# Split-out validation df
array = df.values
data_x = array[:,1:len -1]
data_y = array[:,len - 1]

x_train, x_test, y_train, y_test   =  model_selection.train_test_split (data_x, data_y, test_size = 0.2, random_state = 42)

#Start machine learning.

knn = KNeighborsClassifier()
knn.fit(x_train,y_train.astype(int))
accuracy = knn.score(x_test, y_test.astype(int))

#print("Accuracy = {}%".format(accuracy * 100)) - need to buils another table for saving the process of the accuracy

#Save the ML

joblib.dump(knn, 'C:\\SeScFRD\\SavedModels\\FraudML.pkl')
