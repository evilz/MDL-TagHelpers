cd samples/MaterialDesignLite.WebSample

start dnx web

cd ../..
 
SLEEP 7
cd Webcopy
WCOPY http://localhost:5004 /recursive /o ../StaticDemo
