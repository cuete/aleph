# aleph
By [Alejandro Echeverria](https://github.com/cuete)

## Project description
Log streaming utility

## Code Name
aleph

## Description
Lightweight service to stream consolidated logs from different sources in real time.

## Acceptance Criteria
* Collect multiple data source types
    * Csv and tsv text from the local system and remote storages
    * Azure function and app service log streamer
    * Azure storage tables and queues
    * Extensible to support other types of sources and APIs
* Ability to save, edit and view sources
* Ability to enable/disable sources and filter data in real time.
* Read only, it should not lock source files.
* Run as an API service, consume through client (console or web)
* Deliver normalized json output data
* Go idle when not in use
* Stream multiple sources in one channel (mixed or in parallell)
* Grouping by common attributes
* Support multiple concurrent channels
* Must be able to pause/stop/go/browse/search the stream
* Limit size of stream in memory
* Support Regex filtering and search
* Secure transfer (compressed?)
* Client authentication
* Ability to save a snapshot to a text file
* Mobile compatibility (web client)

## Phase 1
* Collect data from text files
* Collect data from APIs
* Normalize data
* Stream to console
* Configurable filters/sources through config file
* Memory management

## Phase 2
* Service API
* Real time selection and filtering
* Secure transfer and authentication (compression?)
* Console client

## Phase 3
* Save snapshot to text file
* Web client, mobile compatible
* Regex support
* Optimization
