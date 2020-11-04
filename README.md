# GPS Sim

This software was written in C# using WinForms.
It processes MoTeC log files of real GPS data from race cars fitted with a GPS receiver, and outputs a raw NMEA stream that can be played back over RS232.
This enables simulation of race track conditions on the bench and allows me to perform testing I've never been able to do before on the bench.

NMEA GPS Playback software and replay from MoTeC ld

How to create NMEA data from MoTeC LD file for replay In i2:

- Open log file with desired lap
- Set normal cursor just to the left of the lap start Set datum cursor just to the right of the lap end
- File > Split data (to have exported log file for reference and reproduction) Split at cursor and datum Uncheck left and right Close original and open new files
- Create a new T/D graph and add the following channels (if available): GPS Altitude, GPS WGS84 Height, GPS Date, GPS Fix Quality, GPS HDOP, GPS Satellites, GPS Time, GPS Latitude, GPS Longitude, GPS True Course, GPS Speed
Note: GPS Lat/Long, and Time are the only required channels. All other channels optional
- Right click on T/D graph > Export data, Source Channels = Visible Channels, Data Extent = Visible Data, Export Options Output File Format = CSV File, Output Sample Rate = 10 Hz, Include Time Stamp, DON'T Include Distance Data

- Open the csv in sublimeText2 editor
- Delete unrequired lines so that the first line is channel names, everything following is data Ensure all values are in double closed and comma separated, for example:

"Time","GPS Altitude","GPS Date","GPS Time","GPS Latitude","GPS Longitude","GPS Speed" "0.000","57.4","70517","30002.100","-38.4972788","145.2323601","70.9" "0.100","57.3","70517","30002.200","-38.4972805","145.2323380","70.6"

Note: If planning to loop the replay, go through the file and make sure we cut off the start and end so that the lap doesn’t repeat In i2 find the GPS Time sample just to the left of start of lap. For example: 4162.400 In csv file locate that GPS Time value and delete everything above it In i2 find the GPS Time sample just to the LEFT of the end of the lap. Delete everything below it in csv file Save the file

How to convert csv to NMEA stream ready for replay:
- Open GPS Simulator 
- Set the Input file to the location of CSV file generated
- Set the Output file to the directory where you want the file dumped. Give it a name (optional), and the file will be created there
- Click 'Generate'. Some text will appear in the text box below when the process is finished.

How to replay NMEA streams on COM port:
- Set Output file to the txt file containing valid NMEA stream. This file doesn't have to be created by the software. It just has to be valid.
- Set the desired COM port and baud rate
- Click 'Connect' to latch onto the port. The software will inform the connection was successful, or reject if something else already has claimed it.
- Set Data settings. Repeats = 0 will loop the file indefinitely. This is the default. Set a number here if you want a fixed amount of replays. 
Set the Speed. This is currently hardcoded at 1x. This means if the data is exported at 10hz, there will be 10 lines per second. (#TODO: Implement)
- Click 'Send' to start transmission. Data transmitted on the port will be streamed on the right hand pane of the program. Click 'Clear' at any time to clear the text box
- Click 'Stop' to stop transmission. (#TODO: Implement Pause)

i2 API
Coming soon, integration with i2 API, to remove the need to create initial csv, and connect directly to MoTeC i2

#TODO: Implement Speed settings other than 1x

#TODO: Implement pause and resume playback

#TODO: Implement save user settings:
- Last replayed file
- Last generated file
- Last 10 played back files

#TODO: Connect to i2 API
